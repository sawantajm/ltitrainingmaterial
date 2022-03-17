import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EventhandlingComponent } from './eventhandling.component';

describe('EventhandlingComponent', () => {
  let component: EventhandlingComponent;
  let fixture: ComponentFixture<EventhandlingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EventhandlingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EventhandlingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
