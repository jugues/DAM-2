package com.example.datepickersencillo;

import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;

import java.util.Calendar;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    Button btnFecha;
    EditText etFecha;
    private int dia, mes, anyo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnFecha = (Button) findViewById(R.id.btnFecha);
        etFecha = (EditText) findViewById(R.id.etFecha);
        btnFecha.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {

        final Calendar c = Calendar.getInstance();
        dia = c.get(Calendar.DAY_OF_MONTH);
        mes = c.get(Calendar.MONTH);
        anyo = c.get(Calendar.YEAR);

        DatePickerDialog dpd = new DatePickerDialog(this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker view, int year, int month, int day) {

                etFecha.setText(day + "/" + (month + 1 ) + "/" + year);
            }
        }, anyo, mes, dia);

        dpd.updateDate(anyo, mes, dia);
        dpd.show();
    }
}