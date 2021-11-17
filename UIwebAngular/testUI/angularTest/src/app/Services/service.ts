import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError} from 'rxjs/operators';
import { patient } from '../models/patient';

 @Injectable({
    providedIn: 'root'
 })
export class crudService {
  insertURL: string = "https://localhost:44334/api/AddPatient";
  getURL: string = "https://localhost:44334/api/GetPatient";
  setURL: string = "https://localhost:44334/api";

  constructor(private http: HttpClient) {
  }

   getMethod(data:any):Observable<patient>{
    const _httpHeaders = new HttpHeaders();
    _httpHeaders.append('content-type', 'application/json');
    return this.http.get<patient>(this.getURL, { headers: _httpHeaders, params: data });

  }

  setMethod(data:any):Observable<patient>{
    return this.http.post<patient>(this.setURL+'/UpdatePatient',data,);
  }

  addMethod(data:any):Observable<patient>{
    return this.http.post<patient>(this.insertURL,data);
  }
}
