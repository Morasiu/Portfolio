import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutFieldComponent } from './about-field.component';

describe('ExperienceComponent', () => {
  let component: AboutFieldComponent;
  let fixture: ComponentFixture<AboutFieldComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AboutFieldComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutFieldComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
