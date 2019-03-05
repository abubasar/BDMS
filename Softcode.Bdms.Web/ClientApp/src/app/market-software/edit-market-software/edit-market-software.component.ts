import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { MarketSoftware } from 'src/app/market-software';
import { MarketSoftwareService } from 'src/app/service/market-software.service';
import { ActivatedRoute, Router } from '@angular/router';
import { MarketingStatusService } from 'src/app/service/marketing-status.service';
import { MarketingStatus } from 'src/app/marketing-status';

@Component({
  selector: 'app-edit-market-software',
  templateUrl: './edit-market-software.component.html',
  styleUrls: ['./edit-market-software.component.css']
})
export class EditMarketSoftwareComponent extends BaseComponent<MarketSoftware> implements OnInit {
  
model:MarketSoftware
statuses:MarketingStatus[]
  constructor(service:MarketSoftwareService,activatedRoute:ActivatedRoute,private statusService:MarketingStatusService,router:Router) {
    super(service,activatedRoute,router);
  }


  ngOnInit() {
    
    this.get();
    this.loadStatus();
  }
  reset() {
    this.model=new MarketSoftware()
  }

  loadStatus():void{
    this.statusService.load(this.searchRequest).subscribe(res=>{
      this.statuses=res;
      console.log(res)
      });

    }
}
