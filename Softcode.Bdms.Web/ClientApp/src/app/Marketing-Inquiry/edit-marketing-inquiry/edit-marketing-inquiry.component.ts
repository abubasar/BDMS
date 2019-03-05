import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { MarketingInquiry } from 'src/app/marketing-inquiry';
import { ActivatedRoute, Router } from '@angular/router';
import { MarketingInquiryService } from 'src/app/service/marketing-inquiry.service';

@Component({
  selector: 'app-edit-marketing-inquiry',
  templateUrl: './edit-marketing-inquiry.component.html',
  styleUrls: ['./edit-marketing-inquiry.component.css']
})
export class EditMarketingInquiryComponent extends BaseComponent<MarketingInquiry> implements OnInit {
  reset() {
    this.model=new MarketingInquiry()
  }

  constructor(service:MarketingInquiryService,activatedRoute:ActivatedRoute,router:Router) {
    super(service,activatedRoute,router);
  }

  ngOnInit() {
    this.get()
  }

}
