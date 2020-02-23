import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { PaginationModule } from 'ngx-bootstrap/pagination'; 
import { CountriesRoutingModule } from './countries-routing.module';
import { CountriesComponent } from './countries.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [CountriesComponent],
  imports: [
    CommonModule,
    FormsModule,
    CountriesRoutingModule,
    ButtonsModule.forRoot(),
    PaginationModule.forRoot()
  ]
})
export class CountriesModule { }
