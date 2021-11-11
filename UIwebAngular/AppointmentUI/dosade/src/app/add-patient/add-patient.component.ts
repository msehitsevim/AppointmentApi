import { Component, OnInit } from '@angular/core';
//import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-add-patient',
  templateUrl: './add-patient.component.html',
  styleUrls: ['./add-patient.component.css']
})

export class AddPatientComponent  {
  
 // constructor(private http: HttpClient){}
  onSubmit(data : any){
    console.warn(data);
  }
  ngOnInit() { 
   // this.http.post<Patient>('https://localhost:44334/api/AddPatient', { title: 'Angular POST Request Example' }).subscribe(data => {
   //   this.addPatient = data;
    //})
  }
}




