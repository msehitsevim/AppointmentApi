import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddPatientComponent } from './add-patient/add-patient.component';
import { AddAppointmentComponent } from './add-appointment/add-appointment.component';
import { GetPatientComponent } from './get-patient/get-patient.component';
const routes: Routes = [
  {path: 'add-patient', component: AddPatientComponent},
  {path: 'add-appointment', component: AddAppointmentComponent},
  {path: 'get-patient', component: GetPatientComponent}
  
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
