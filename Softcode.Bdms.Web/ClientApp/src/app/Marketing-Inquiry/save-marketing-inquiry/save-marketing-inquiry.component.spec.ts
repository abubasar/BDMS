import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SaveMarketingInquiryComponent } from './save-marketing-inquiry.component';

describe('SaveMarketingInquiryComponent', () => {
  let component: SaveMarketingInquiryComponent;
  let fixture: ComponentFixture<SaveMarketingInquiryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SaveMarketingInquiryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SaveMarketingInquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
