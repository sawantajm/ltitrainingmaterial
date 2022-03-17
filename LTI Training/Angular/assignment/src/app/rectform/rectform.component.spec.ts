import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RectformComponent } from './rectform.component';

describe('RectformComponent', () => {
  let component: RectformComponent;
  let fixture: ComponentFixture<RectformComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RectformComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RectformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
