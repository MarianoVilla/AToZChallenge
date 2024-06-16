import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CatFactsService {

  private readonly beUrl = "http://localhost:5233/getCatFacts";

  getCatFacts(){
    return this.http.get(this.beUrl);
  }
  constructor(private http: HttpClient) {

  }

}
