import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { MarketingInquiry } from 'src/app/marketing-inquiry';
import { MarketingInquiryService } from 'src/app/service/marketing-inquiry.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-marketing-inquiry-list',
  templateUrl: './marketing-inquiry-list.component.html',
  styleUrls: ['./marketing-inquiry-list.component.css']
})
export class MarketingInquiryListComponent extends BaseComponent <MarketingInquiry> implements OnInit {
  reset() {
    throw new Error("Method not implemented.");
  }

  
  constructor(service:MarketingInquiryService,activatedRoute:ActivatedRoute,router:Router) {
    super(service,activatedRoute,router)
   }

  ngOnInit() {
    this.search()
  }
  update(id:number){
    this.router.navigate(['/edit-marketing-inquiry/'+id]);
      }
}
