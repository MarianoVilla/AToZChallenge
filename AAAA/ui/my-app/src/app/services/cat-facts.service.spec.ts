import { TestBed } from '@angular/core/testing';

import { CatFactsService } from './cat-facts.service';

describe('CatFactsService', () => {
  let service: CatFactsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CatFactsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
