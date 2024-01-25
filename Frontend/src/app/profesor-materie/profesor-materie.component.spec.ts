import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfesorMaterieComponent } from './profesor-materie.component';

describe('ProfesorMaterieComponent', () => {
  let component: ProfesorMaterieComponent;
  let fixture: ComponentFixture<ProfesorMaterieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProfesorMaterieComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProfesorMaterieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
