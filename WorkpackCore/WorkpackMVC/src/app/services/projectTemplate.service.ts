import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { environment } from './../../environments/environment';
import { ProjectTemplate } from './../models/projectTemplate';

@Injectable()
export class ProjectTemplateService {
    private apiLink: string = environment.API_ENDPOINT;

    constructor(private httpClient: HttpClient) {
    }

    getAllProjectTemplate(): Observable<Object> {

        const projectTemplate = [
            {
                NormSetID: 1,
                NormSetName: 'NormSet 1',
                ClientID: 1,
                ProjectType: 1,
                ProjectStage: 1,
                NormSetType: 'NormSetType 1',
                ProjectID: 1,
                IsDefault: 'N',
            }
        ];

        return Observable.of(projectTemplate);

    }

}