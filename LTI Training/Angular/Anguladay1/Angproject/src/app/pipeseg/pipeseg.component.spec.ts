import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PipesegComponent } from './pipeseg.component';

describe('PipesegComponent', () => {
  let component: PipesegComponent;
  let fixture: ComponentFixture<PipesegComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PipesegComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PipesegComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
