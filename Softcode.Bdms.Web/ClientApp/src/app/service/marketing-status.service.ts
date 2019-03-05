import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UrlService } from './url.service';
import { Observable } from 'rxjs';
import { BaseRequestModel } from '../base-request-model';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class MarketingStatusService extends BaseService<any>  {

  constructor(http:HttpClient,url:UrlService) {
 super(http,url.marketstatus)
   }

   
  
}
