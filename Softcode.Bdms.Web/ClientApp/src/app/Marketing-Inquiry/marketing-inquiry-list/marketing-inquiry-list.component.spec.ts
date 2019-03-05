import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketingInquiryListComponent } from './marketing-inquiry-list.component';

describe('MarketingInquiryListComponent', () => {
  let component: MarketingInquiryListComponent;
  let fixture: ComponentFixture<MarketingInquiryListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MarketingInquiryListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MarketingInquiryListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
