import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'countries',
    loadChildren: () => import('./countries/countries.module')
      .then(m => m.CountriesModule)
  },
  {
    path: 'countries/view/:id',
    loadChildren: () => import('./country/country.module')
      .then(m => m.CountryModule)
  },
  {
    path: '',
    redirectTo: 'countries',
    pathMatch: 'full',
  }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
