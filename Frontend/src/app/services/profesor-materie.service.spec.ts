import { TestBed } from '@angular/core/testing';

import { ProfesorMaterieService } from './profesor-materie.service';

describe('ProfesorMaterieService', () => {
  let service: ProfesorMaterieService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProfesorMaterieService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
