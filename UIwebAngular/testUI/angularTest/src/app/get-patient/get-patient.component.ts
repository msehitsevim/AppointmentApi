import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Params } from '@angular/router';
import { Observable } from 'rxjs';
import { patient } from '../models/patient';

@Component({
  selector: 'app-get-patient',
  templateUrl: './get-patient.component.html',
  styleUrls: ['./get-patient.component.css']
})
export class GetPatientComponent  {
  public Patients : any;
  constructor(private http : HttpClient) {  }
  
  onSubmit(data:any){
    
    console.warn(data);
    //const headers = { 'Authorization': 'Bearer my-token', 'My-Custom-Header': 'foobar' }
    const _httpHeaders = new HttpHeaders();
    _httpHeaders.append('content-type','application/json');
    this.http.get<patient[]>('https://localhost:44334/api/GetPatient',{headers:_httpHeaders,params:data}).subscribe((data)=>{
      this.Patients = data;
  });
    
  }
}

