import { Component, OnInit,ViewEncapsulation } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PaymentsenseCodingChallengeApiService } from '../services';

@Component({
  selector: 'app-countries',
  templateUrl: './countries.component.html',
  styleUrls: ['./countries.component.scss'],
  encapsulation: ViewEncapsulation.None
  
})
export class CountriesComponent implements OnInit {
 //#region variables
 countries = [];
 loading: boolean;
 pageSize : number =10;
 totalItems: number = 0;
 currentPage: number = 1;
 page:number=0;
 smallnumPages: number = 0;
 maxSize:number =10;
 collectionSize:number =10;
 
 //#endregion
  constructor(
    private dataService: PaymentsenseCodingChallengeApiService
  ) { }

  viewMode() {
    this.loading = true;

    setTimeout(() => {
      this.countries.push(...this.countries);
      this.loading = false;
    }, 500);
  }

  ngOnInit() {
    this.fetch();
  }
  fetch() {
    this.page+=1;
    this.dataService.get(`?page=${this.currentPage}&take=${this.pageSize}`).toPromise().then((data: any) => {
      // success 
      this.countries=data.list;
      this.totalItems=data.totalItems;
    }).catch((error) => {

    });
  }
  pageChanged(event: any): void {
    this.currentPage=event.page;
    this.fetch();
  }

}
