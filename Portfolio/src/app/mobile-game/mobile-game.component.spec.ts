import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MobileGameComponent } from './mobile-game.component';

describe('GameComponent', () => {
  let component: MobileGameComponent;
  let fixture: ComponentFixture<MobileGameComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MobileGameComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MobileGameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
