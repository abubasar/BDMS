import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { MarketSoftware } from 'src/app/market-software';
import { MarketSoftwareService } from 'src/app/service/market-software.service';
import { MarketingStatusService } from 'src/app/service/marketing-status.service';
import { BaseRequestModel } from 'src/app/base-request-model';

@Component({
  selector: 'app-save-market-software',
  templateUrl: './save-market-software.component.html',
  styleUrls: ['./save-market-software.component.css']
})
export class SaveMarketSoftwareComponent extends BaseComponent<MarketSoftware> implements OnInit {
  statuses:any[]
  searchRequest:BaseRequestModel
  constructor(service:MarketSoftwareService,private marketingStatusService:MarketingStatusService) {
    super(service);
    this.model=new MarketSoftware();
    this.searchRequest=new BaseRequestModel();
    this.searchRequest.page=1
    this.searchRequest.perPageCount=10
    this.searchRequest.orderBy="statusName"
    this.searchRequest.isAscending=false;
  }

  ngOnInit() {
   this.loadMarketSoftwareStatus();
  }

  loadMarketSoftwareStatus():void{
    this.marketingStatusService.getAllStatusForDropdown(this.searchRequest).subscribe(res=>{
      this.statuses=res;
      console.log(res)
      });
  }

  reset():void {
    this.model=new MarketSoftware();
 
  }



}
