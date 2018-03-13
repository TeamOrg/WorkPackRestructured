//using System;
//using System.Collections.Generic;
//using System.Linq;
//using DataAccessLibrary;
//using DomainModelLibrary;

//namespace BusinessLibrary
//{
//    public class DocfreqWithID
//    {
//        public int docid { get; set; }
//        public int termcount { get; set; }
//    }
//    public static class CustomSearch
//    {
     
//        // properties
  
//   public  static  String Comp=Convert.ToString(HttpContext.Current.Session["ComanyName"]) == "" ?"" : Convert.ToString(HttpContext.Current.Session["ComanyName"]).Trim('.') ;
        
        
//   public static string _luceneDir = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "CustomSearch_index", Comp);
      
//        private static FSDirectory _directoryTemp;
//        private static FSDirectory _directory
//        {
//            get
//            {
//                 string _luceneDir = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "CustomSearch_index", Comp);
//                 _directoryTemp = FSDirectory.Open(new DirectoryInfo(_luceneDir));
//                if (_directoryTemp == null) _directoryTemp = FSDirectory.Open(new DirectoryInfo(_luceneDir));
//                if (IndexWriter.IsLocked(_directoryTemp)) IndexWriter.Unlock(_directoryTemp);
//                var lockFilePath = Path.Combine(_luceneDir, "write.lock");
//                if (File.Exists(lockFilePath)) File.Delete(lockFilePath);
//                return _directoryTemp;
//            }
//        }

//        // search methods
//        public static IEnumerable<IndexDataTable> GetAllIndexRecords()
//        {
//            // validate search index
//            string _luceneDir = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "CustomSearch_index", Comp);
//            if (!System.IO.Directory.EnumerateFiles(_luceneDir).Any()) return new List<IndexDataTable>();

//            // set up lucene searcher
//            var searcher = new IndexSearcher(_directory, false);
//            var reader = IndexReader.Open(_directory, false);
//            var docs = new List<Document>();
//            var term = reader.TermDocs();
//            // v 2.9.4: use 'hit.Doc()'
//            // v 3.0.3: use 'hit.Doc'
//            while (term.Next()) docs.Add(searcher.Doc(term.Doc));
//            reader.Dispose();
//            searcher.Dispose();
//            return _mapLuceneToDataList(docs);
//        }
//        public static IEnumerable<IndexDataTable> Search(string input, string fieldName = "")
//        {
//            if (string.IsNullOrEmpty(input)) return new List<IndexDataTable>();

//            var terms = input.Trim().Replace("-", " ").Split(' ')
//                .Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Trim() + "*");
//            input = string.Join(" ", terms);

//            return _search(input, fieldName);
//        }
//        public static IEnumerable<IndexDataTable> SearchDefault(string input, string fieldName = "")
//        {
//            return string.IsNullOrEmpty(input) ? new List<IndexDataTable>() : _search(input, fieldName);
//        }

//        // main search method
//        private static IEnumerable<IndexDataTable> _search(string searchQuery, string searchField = "")
//        {
//            // validation
//            if (string.IsNullOrEmpty(searchQuery.Replace("*", "").Replace("?", ""))) return new List<IndexDataTable>();
//            IEnumerable<IndexDataTable> res = null;
//            // set up lucene searcher
//            try
//            {
//                using (var searcher = new IndexSearcher(_directory, false))
//                {
//                    var hits_limit = 1000;
//                    var analyzer = new StandardAnalyzer(Version.LUCENE_30);

//                    // search by single field
//                    if (!string.IsNullOrEmpty(searchField))
//                    {
//                        var parser = new QueryParser(Version.LUCENE_30, searchField, analyzer);
//                        var query = parseQuery(searchQuery, parser);
//                        var hits = searcher.Search(query, hits_limit).ScoreDocs;
//                        var results = _mapLuceneToDataList(hits, searcher);
//                        analyzer.Close();
//                        searcher.Dispose();
//                        return results;
//                    }
//                    // search by multiple fields (ordered by RELEVANCE)
//                    else
//                    {

//                        var parser = new MultiFieldQueryParser
//                            (Version.LUCENE_30, new[] { "IndexID", "FileName", "FileKeywords" }, analyzer);
//                        var query = parseQuery(searchQuery, parser);
//                        IndexReader reader = IndexReader.Open(_directory, true);
//                        var hits = searcher.Search(query, null, hits_limit, Sort.INDEXORDER).ScoreDocs;
//                        int totalFreq = 0;
//                        Term t = new Term("FileKeywords", searchQuery.Replace("*", ""));
//                        TermDocs termDocs = reader.TermDocs(t);
//                        Dictionary<string, int> dict = new Dictionary<string, int>();
//                        int count = 0;
//                        int i = 0;
//                        List<DocfreqWithID> lst = new List<DocfreqWithID>();
//                        while (termDocs.Next())
//                        {
//                            var docID = hits[i].Doc;
//                            Document doc = reader.Document(docID);
//                            count += termDocs.Freq;
//                            DocfreqWithID docfreq = new DocfreqWithID();
//                            docfreq.docid = Convert.ToInt32(doc.Get("IndexID"));
//                            docfreq.termcount = Convert.ToInt32(termDocs.Freq);
//                            lst.Add(docfreq);
//                            //dict.Add(doc.Get("FileName"), termDocs.Freq);
//                            i++;
//                        }
//                        lst = lst.OrderByDescending(c => c.termcount).ToList<DocfreqWithID>();
//                        List<IndexDataTable> lstindex = new List<IndexDataTable>();
//                        var results = _mapLuceneToDataList(hits, searcher);
//                        foreach (var item in lst)
//                        {
//                            IndexDataTable indext = new IndexDataTable();
//                            var slist = results.Where(c => c.IndexID == item.docid);
//                            if (slist.Count() > 0)
//                            {
//                                IFormatter formatter = new Lucene.Net.Search.Highlight.SimpleHTMLFormatter("<span style='background:#32BEF3;'>", "</span>");
//                                SimpleFragmenter fragmenter = new SimpleFragmenter(400);
//                                QueryScorer scorer = new QueryScorer(query);
//                                Highlighter highlighter = new Highlighter(formatter, scorer);
//                                highlighter.MaxDocCharsToAnalyze = 20840000;
//                                TokenStream stream = analyzer.TokenStream("", new StringReader(slist.SingleOrDefault().FileKeywords));
//                                string highlightedText = highlighter.GetBestFragments(stream, slist.SingleOrDefault().FileKeywords, 1, "...");

//                                //string highlighted_text = highlighter.GetBestFragment(analyzer, "FieldKeywords", searchQuery.Replace("*", ""));
//                                indext.IndexID = slist.SingleOrDefault().IndexID;
//                                indext.FileName = slist.SingleOrDefault().FileName.ToString();
//                                indext.FileKeywords = highlightedText;
//                                lstindex.Add(indext);
//                            }
//                        }

//                        if (lst.Count == 0)
//                        {
//                            foreach (var item in results)
//                            {
//                                IndexDataTable indext = new IndexDataTable();
//                                IFormatter formatter = new Lucene.Net.Search.Highlight.SimpleHTMLFormatter("<span style='background:#32BEF3;'>", "</span>");
//                                SimpleFragmenter fragmenter = new SimpleFragmenter(400);
//                                QueryScorer scorer = new QueryScorer(query);
//                                Highlighter highlighter = new Highlighter(formatter, scorer);
//                                highlighter.MaxDocCharsToAnalyze = 20840000;
//                                TokenStream stream = analyzer.TokenStream("", new StringReader(item.FileKeywords));
//                                string highlightedText = highlighter.GetBestFragments(stream, item.FileKeywords, 1, "...");

//                                //string highlighted_text = highlighter.GetBestFragment(analyzer, "FieldKeywords", searchQuery.Replace("*", ""));
//                                indext.IndexID = item.IndexID;
//                                indext.FileName = item.FileName.ToString();
//                                indext.FileKeywords = highlightedText;
//                                lstindex.Add(indext);

//                            }
//                        }
//                       res = lstindex.ToList<IndexDataTable>();
//                        reader.Dispose();
//                        analyzer.Close();
//                        searcher.Dispose();

//                        return res;
//                    }
//                }
//            }
//            catch (FileNotFoundException)
//            {
//               return res  ;
//            }
           
          

//        }
//        private static Query parseQuery(string searchQuery, QueryParser parser)
//        {
//            Query query;
//            try
//            {
//                query = parser.Parse(searchQuery.Trim());
//            }
//            catch (ParseException)
//            {
//                query = parser.Parse(QueryParser.Escape(searchQuery.Trim()));
//            }
//            return query;
//        }

//        // map Lucene search index to data
//        private static IEnumerable<IndexDataTable> _mapLuceneToDataList(IEnumerable<Document> hits)
//        {
//            return hits.Select(_mapLuceneDocumentToData).ToList();
//        }
//        private static IEnumerable<IndexDataTable> _mapLuceneToDataList(IEnumerable<ScoreDoc> hits, IndexSearcher searcher)
//        {
//            // v 2.9.4: use 'hit.doc'
//            // v 3.0.3: use 'hit.Doc'
//            return hits.Select(hit => _mapLuceneDocumentToData(searcher.Doc(hit.Doc))).ToList();
//        }
//        private static IndexDataTable _mapLuceneDocumentToData(Document doc)
//        {
//            return new IndexDataTable
//            {
//                IndexID = Convert.ToInt32(doc.Get("IndexID")),
//                FileName = doc.Get("FileName"),
//                FileKeywords = doc.Get("FileKeywords")
//            };
//        }

//        // add/update/clear search index data 
//        public static void AddUpdateLuceneIndex(IndexDataTable indexData)
//        {
//            AddUpdateLuceneIndex(new List<IndexDataTable> { indexData });
//        }
//        public static void AddUpdateLuceneIndex(IEnumerable<IndexDataTable> indexData)
//        {
//            // init lucene
//            var analyzer = new StandardAnalyzer(Version.LUCENE_30);
//            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
//            {
//                // add data to lucene search index (replaces older entries if any)
//                foreach (var sampleData in indexData) _addToLuceneIndex(sampleData, writer);

//                // close handles
//                analyzer.Close();
//                writer.Dispose();
//            }
//        }
//        public static void ClearLuceneIndexRecord(int record_id)
//        {

//            // init lucene
//            try
//            {
//                var analyzer = new StandardAnalyzer(Version.LUCENE_30);
//                using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
//                {
//                    // remove older index entry
//                    var searchQuery = new TermQuery(new Term("IndexID", record_id.ToString()));
//                    writer.DeleteDocuments(searchQuery);

//                    // close handles
//                    analyzer.Close();
//                    writer.Dispose();
//                }
//            }
//            catch (Exception ex)
//            { }
//        }


//        public static bool ClearLuceneIndex()
//        {
//            try
//            {
//                var analyzer = new StandardAnalyzer(Version.LUCENE_30);
//                using (var writer = new IndexWriter(_directory, analyzer, true, IndexWriter.MaxFieldLength.UNLIMITED))
//                {
//                    // remove older index entries
//                    writer.DeleteAll();

//                    // close handles
//                    analyzer.Close();
//                    writer.Dispose();
//                }
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//            return true;
//        }
//        public static void Optimize()
//        {
//            var analyzer = new StandardAnalyzer(Version.LUCENE_30);
//            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
//            {
//                analyzer.Close();
//                writer.Optimize();
//                writer.Dispose();
//            }
//        }
//        private static void _addToLuceneIndex(IndexDataTable sampleData, IndexWriter writer)
//        {
//            // remove older index entry
//            var searchQuery = new TermQuery(new Term("IndexID", sampleData.IndexID.ToString()));
//            writer.DeleteDocuments(searchQuery);

//            // add new index entry
//            var doc = new Document();

//            // add lucene fields mapped to db fields
//            doc.Add(new Field("IndexID", sampleData.IndexID.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
//            doc.Add(new Field("FileName", sampleData.FileName, Field.Store.YES, Field.Index.ANALYZED));
//            doc.Add(new Field("FileKeywords", sampleData.FileKeywords, Field.Store.YES, Field.Index.ANALYZED));

//            // add entry to index
//            writer.AddDocument(doc);
//        }

//    }

//}
