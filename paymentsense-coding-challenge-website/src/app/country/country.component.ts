import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MockPaymentsenseCodingChallengeApiService } from '../testing/mock-paymentsense-coding-challenge-api.service';
import { PaymentsenseCodingChallengeApiService } from '../services';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.scss']
})
export class CountryComponent implements OnInit {

  default="";
  data;
  name;
  constructor(
    private route: ActivatedRoute,private dataService :PaymentsenseCodingChallengeApiService
  ) { }


  ngOnInit(): void {
  this.fetch();
  }
  fetch()
  {
    this.route.paramMap.subscribe(paramMap => {
      this.name = paramMap.get('id');
      this.dataService.get(`/${this.name}`).toPromise().then((data: any) => {
        this.data=data;
      }).catch((error) => {
  
      });
    
    })
  }
}
