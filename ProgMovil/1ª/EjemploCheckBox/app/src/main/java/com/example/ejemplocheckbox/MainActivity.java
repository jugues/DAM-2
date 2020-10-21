package com.example.ejemplocheckbox;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private float precioTotal;
    private TextView tvTotal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        precioTotal = 0;
        tvTotal=(TextView)findViewById(R.id.tvTotal);
    }

    public void seleccionar(View view) {
        CheckBox nuevo = (CheckBox) view;
        switch(view.getId())
        {
            case R.id.chkBQueso:
                if(((CheckBox)view).isChecked())
                {
                    precioTotal += 0.50;
                }

                else
                {
                    precioTotal -= 0.50;
                }

            case(R.id.chkBPepino):

                if(((CheckBox)view).isChecked())
                {
                    precioTotal += 0.25;
                }

                else
                {
                    precioTotal -= 0.25;
                }

            case(R.id.chkBBacon):

                if(((CheckBox)view).isChecked())
                {
                    precioTotal += 1.50;
                }

                else
                {
                    precioTotal -= 1.50;
                }

                break;
        }
        tvTotal.setText(""+precioTotal);
    }
}