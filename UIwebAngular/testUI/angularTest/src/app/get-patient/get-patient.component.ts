import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
import { patient } from '../models/patient';
import { crudService } from '../Services/service'

@Component({
  selector: 'app-get-patient',
  templateUrl: './get-patient.component.html',
  styleUrls: ['./get-patient.component.css'],

})
export class GetPatientComponent implements OnInit {
  public reqMessage : any;
  public Patients: Array<patient> = [];
  loading: boolean = false;
  errorMessage : any;
  constructor(private crudMethods : crudService) {
  }
  getPatient(data:any){
    this.crudMethods.getMethod(data)
        .subscribe({next : response =>  {
             this.Patients.push(response);
           },error: error=>{
             console.error('Request failed with error')
             this.errorMessage = error;
             this.loading = false;
           }
        })
  }
  setPatient(){
    this.crudMethods.setMethod(this.Patients[0]).subscribe(
      { next: res => {
          this.reqMessage = res;
        }, error: error=>{
          console.error('Update failed with error')
          console.log('error:',error)
          this.errorMessage = error;
          this.loading = false;
        }
      }
    );
}
  ngOnInit(): void { }
}

