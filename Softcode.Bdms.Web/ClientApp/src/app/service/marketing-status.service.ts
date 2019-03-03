import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UrlService } from './url.service';
import { Observable } from 'rxjs';
import { BaseRequestModel } from '../base-request-model';

@Injectable({
  providedIn: 'root'
})
export class MarketingStatusService {

  constructor(private http:HttpClient) {

   }
   private baseUrl:string="http://localhost:12666/api/"
   getAllStatusForDropdown(request:BaseRequestModel):Observable<any>{
     return this.http.post(this.baseUrl+'market-status/'+'Dropdown',request);
   }
}
