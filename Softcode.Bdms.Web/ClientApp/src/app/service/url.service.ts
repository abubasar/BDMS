import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UrlService {
  baseUrl:string="http://localhost:12666/api/"
  marketsoftware:string
    constructor() { 
      this.marketsoftware=this.baseUrl+"market-software"
    }
}
