import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StocksDetails1Component } from './stocks-details1.component';

describe('StocksDetails1Component', () => {
  let component: StocksDetails1Component;
  let fixture: ComponentFixture<StocksDetails1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StocksDetails1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StocksDetails1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
