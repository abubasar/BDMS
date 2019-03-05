import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { MarketSoftware } from 'src/app/market-software';
import { MarketSoftwareService } from 'src/app/service/market-software.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-market-software-list',
  templateUrl: './market-software-list.component.html',
  styleUrls: ['./market-software-list.component.css']
})
export class MarketSoftwareListComponent extends BaseComponent<MarketSoftware> implements OnInit {
  

  constructor(service:MarketSoftwareService,activatedRoute:ActivatedRoute,router:Router) {
    super(service,activatedRoute,router)
   }

  ngOnInit() {
    this.search();
    
  }
  update(id:number){
    this.router.navigate(['/edit/'+id]);
      }
  reset() {
    console.log("not apply")
  }

}
