import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { BsDatepickerModule} from 'ngx-bootstrap';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { MarketSoftwareListComponent } from './market-software/market-software-list/market-software-list.component';
import { BaseService } from './service/base.service';
import { UrlService } from './service/url.service';
import { MarketSoftwareService } from './service/market-software.service';
import { SaveMarketSoftwareComponent } from './market-software/save-market-software/save-market-software.component';
import { MarketingStatusService } from './service/marketing-status.service';
import { EditMarketSoftwareComponent } from './market-software/edit-market-software/edit-market-software.component';
import { MarketingInquiryListComponent } from './Marketing-Inquiry/marketing-inquiry-list/marketing-inquiry-list.component';
import { MarketingInquiryService } from './service/marketing-inquiry.service';
import { SaveMarketingInquiryComponent } from './Marketing-Inquiry/save-marketing-inquiry/save-marketing-inquiry.component';
import { EditMarketingInquiryComponent } from './Marketing-Inquiry/edit-marketing-inquiry/edit-marketing-inquiry.component';
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MarketSoftwareListComponent,
    SaveMarketSoftwareComponent,
    EditMarketSoftwareComponent,
    MarketingInquiryListComponent,
    SaveMarketingInquiryComponent,
    EditMarketingInquiryComponent,
   
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    BsDatepickerModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      {path:'list',component:MarketSoftwareListComponent},
      {path:'add',component:SaveMarketSoftwareComponent},
      {path:'edit/:id',component:EditMarketSoftwareComponent},
      {path:'list-marketing-inquiry', component:MarketingInquiryListComponent},
      {path:'save-marketing-inquiry', component:SaveMarketingInquiryComponent},
      {path:'edit-marketing-inquiry/:id', component:EditMarketingInquiryComponent}
    ])
  ],
  providers: [
    BaseService,
    UrlService,
    MarketSoftwareService,
    MarketingStatusService,
    MarketingInquiryService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
