import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaterieComponent } from './materie.component';

describe('MaterieComponent', () => {
  let component: MaterieComponent;
  let fixture: ComponentFixture<MaterieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MaterieComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MaterieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
