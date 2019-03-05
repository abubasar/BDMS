import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { MarketSoftware } from 'src/app/market-software';
import { MarketSoftwareService } from 'src/app/service/market-software.service';
import { MarketingStatusService } from 'src/app/service/marketing-status.service';
import { ActivatedRoute, Router } from '@angular/router';
import { MarketingStatus } from 'src/app/marketing-status';

@Component({
  selector: 'app-save-market-software',
  templateUrl: './save-market-software.component.html',
  styleUrls: ['./save-market-software.component.css']
})
export class SaveMarketSoftwareComponent extends BaseComponent<MarketSoftware> implements OnInit {
  statuses:MarketingStatus[]
  constructor(service:MarketSoftwareService,activatedRoute:ActivatedRoute,router:Router,private statusService:MarketingStatusService) {
    super(service,activatedRoute,router);
   
  }

  ngOnInit() {
   this.loadStatus();
  }

  loadStatus():void{
    this.statusService.load(this.searchRequest).subscribe(res=>{
      this.statuses=res;
      console.log(res)
      });

    }

  reset():void {
    
 
  }



}
