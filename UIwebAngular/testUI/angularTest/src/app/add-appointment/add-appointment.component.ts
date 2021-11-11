import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-add-appointment',
  templateUrl: './add-appointment.component.html',
  styleUrls: ['./add-appointment.component.css']
})
export class AddAppointmentComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }
  onSubmit(data : any){
    console.warn(data);
    
    this.http.post('https://localhost:44334/api/AddAppointment',data).subscribe((result)=>{console.warn("result",result)});
  }
}
