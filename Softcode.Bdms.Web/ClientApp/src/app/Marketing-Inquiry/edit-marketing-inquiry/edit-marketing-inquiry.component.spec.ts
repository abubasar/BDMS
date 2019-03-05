import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditMarketingInquiryComponent } from './edit-marketing-inquiry.component';

describe('EditMarketingInquiryComponent', () => {
  let component: EditMarketingInquiryComponent;
  let fixture: ComponentFixture<EditMarketingInquiryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditMarketingInquiryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditMarketingInquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
