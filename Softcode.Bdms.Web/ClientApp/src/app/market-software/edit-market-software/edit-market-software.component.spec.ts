import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditMarketSoftwareComponent } from './edit-market-software.component';

describe('EditMarketSoftwareComponent', () => {
  let component: EditMarketSoftwareComponent;
  let fixture: ComponentFixture<EditMarketSoftwareComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditMarketSoftwareComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditMarketSoftwareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
