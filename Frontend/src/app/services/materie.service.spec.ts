import { TestBed } from '@angular/core/testing';

import { MaterieService } from './materie.service';

describe('MaterieService', () => {
  let service: MaterieService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MaterieService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
