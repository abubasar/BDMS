import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Entity } from '../entity';
import { BaseRequestModel } from '../base-request-model';
import { MarketSoftware } from '../market-software';

@Injectable({
  providedIn: 'root'
})
export class BaseService<T> {

  commandUrl:string

  constructor(public http:HttpClient,url:string) {
    this.commandUrl=url;
   }

   save(data:Entity):Observable<any>{
    return  this.http.post(this.commandUrl+'/add',data);
  }

   search(request:BaseRequestModel):Observable<any>{
   
      return this.http.post<any>(this.commandUrl+'/search',request);
   }
}
