import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class MenuService{

  homeAddress = 'api/Menu';
  apiHost = "http://localhost:59239";
  constructor(public httpClient: HttpClient) {
  }

  GetAll() :Observable<any> {
    return this.httpClient.get(`${this.apiHost}/${this.homeAddress}/GetAll`);
  }

  GetData(query) :Observable<any> {
    return this.httpClient.get(`${this.apiHost}/${this.homeAddress}/GetData/${query}`);
  }

 
}
