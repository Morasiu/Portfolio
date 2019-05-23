import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WebProjectComponent } from './web-project.component';

describe('WebProjectComponent', () => {
  let component: WebProjectComponent;
  let fixture: ComponentFixture<WebProjectComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WebProjectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WebProjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
