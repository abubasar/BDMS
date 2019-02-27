import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { MarketSoftwareListComponent } from './market-software/market-software-list/market-software-list.component';
import { BaseService } from './service/base.service';
import { UrlService } from './service/url.service';
import { MarketSoftwareService } from './service/market-software.service';
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MarketSoftwareListComponent,
   
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      {path:'list',component:MarketSoftwareListComponent}
    ])
  ],
  providers: [
    BaseService,
    UrlService,
    MarketSoftwareService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
