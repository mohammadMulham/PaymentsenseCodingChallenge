import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentsenseCodingChallengeApiService {
  baseURL = "http://localhost:56587/PaymentsenseCodingChallenge";

  constructor(private httpClient: HttpClient) {}
  public getHealth(): Observable<string> {
    return this.httpClient.get('http://localhost:56587/health', { responseType: 'text' });
  }
  get(url: string): Observable<any> {
    return this.httpClient.get(this.baseURL + url);
  }
}
