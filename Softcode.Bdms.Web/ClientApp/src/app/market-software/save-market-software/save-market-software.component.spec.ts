import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SaveMarketSoftwareComponent } from './save-market-software.component';

describe('SaveMarketSoftwareComponent', () => {
  let component: SaveMarketSoftwareComponent;
  let fixture: ComponentFixture<SaveMarketSoftwareComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SaveMarketSoftwareComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SaveMarketSoftwareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
