import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { MarketingInquiry } from 'src/app/marketing-inquiry';
import { MarketingInquiryService } from 'src/app/service/marketing-inquiry.service';
import { ActivatedRoute, Router } from '@angular/router';
import { BsDatepickerConfig } from 'ngx-bootstrap';

@Component({
  selector: 'app-save-marketing-inquiry',
  templateUrl: './save-marketing-inquiry.component.html',
  styleUrls: ['./save-marketing-inquiry.component.css']
})
export class SaveMarketingInquiryComponent extends BaseComponent<MarketingInquiry> implements OnInit {
  reset() {
   this.model=new MarketingInquiry()
  }
  ngOnInit(){
   
  }
  bsConfig:Partial<BsDatepickerConfig>
  constructor(service:MarketingInquiryService,activatedRoute:ActivatedRoute,router:Router) {
    super(service,activatedRoute,router);

  


  }

  

}
