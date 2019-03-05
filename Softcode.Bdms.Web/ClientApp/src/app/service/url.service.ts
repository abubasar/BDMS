import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UrlService {
  baseUrl:string="http://localhost:12666/api/"
  marketsoftware:string;
  marketstatus:string
    constructor() { 
      this.marketsoftware=this.baseUrl+"market-software"
      this.marketstatus=this.baseUrl+"market-status"
     
    }
}
