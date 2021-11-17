import { Component, OnInit } from '@angular/core';
import { crudService } from '../Services/service';
@Component({
  selector: 'app-add-patient',
  templateUrl: './add-patient.component.html',
  styleUrls: ['./add-patient.component.css']
})
export class AddPatientComponent implements OnInit {

  constructor(private addPatient: crudService) { }

  ngOnInit(): void {
  }
  onSubmit(data : any){

    this.addPatient.addMethod(data).subscribe((result)=>{console.warn("result",result)});

  }
}
