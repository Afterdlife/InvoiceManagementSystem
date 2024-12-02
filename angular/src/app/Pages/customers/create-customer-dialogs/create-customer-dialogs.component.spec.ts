import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateCustomerDialogsComponent } from './create-customer-dialogs.component';

describe('CreateCustomerDialogsComponent', () => {
  let component: CreateCustomerDialogsComponent;
  let fixture: ComponentFixture<CreateCustomerDialogsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateCustomerDialogsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateCustomerDialogsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
