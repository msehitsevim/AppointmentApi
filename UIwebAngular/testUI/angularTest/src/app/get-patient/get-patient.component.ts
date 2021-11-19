import { Component, OnInit } from '@angular/core';


import { crudService } from '../Services/service'

@Component({
  selector: 'app-get-patient',
  templateUrl: './get-patient.component.html',
  styleUrls: ['./get-patient.component.css'],

})
export class GetPatientComponent implements OnInit {
  public reqMessage : any;
 // public Patients: Array<patient> = [];
  public Patients: any;
  loading: boolean = false;
  errorMessage : any;
  constructor(private crudMethods : crudService) {
  }
  getPatient(data:any){
    this.crudMethods.getMethod(data)
        .subscribe({next : response =>  {
           //  this.Patients.push(response);
           this.Patients = response;
           },error: error=>{
             console.error('Request failed with error')
             this.errorMessage = error;
             this.loading = false;
           }
        })
  }
  setPatient(){
    this.crudMethods.setMethod(this.Patients).subscribe(
      { next: res => {
          this.reqMessage = res;
          console.log("res:",res);
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

