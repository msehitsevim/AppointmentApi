import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-add-patient',
  templateUrl: './add-patient.component.html',
  styleUrls: ['./add-patient.component.css']
})
export class AddPatientComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }
  onSubmit(data : any){
    console.warn(data);
    
    this.http.post('https://localhost:44334/api/AddPatient',data).subscribe((result)=>{console.warn("result",result)});
  }
}
