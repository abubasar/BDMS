import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketSoftwareListComponent } from './market-software-list.component';

describe('MarketSoftwareListComponent', () => {
  let component: MarketSoftwareListComponent;
  let fixture: ComponentFixture<MarketSoftwareListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MarketSoftwareListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MarketSoftwareListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
