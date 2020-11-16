package com.example.restaurante;

import androidx.appcompat.app.AppCompatActivity;

import android.media.Image;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.widget.AdapterView;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TextView;

import org.w3c.dom.Text;

import static com.example.restaurante.R.drawable.hamburguesa_pollo;
import static com.example.restaurante.R.drawable.hamburguesa_ternera;
import static com.example.restaurante.R.drawable.hamburguesa_vegana;

public class MainActivity extends AppCompatActivity implements CompoundButton.OnCheckedChangeListener {

    CheckBox chkQueso, chkBacon, chkPepino;
    private RadioGroup rgTipoBurger;
    private RadioButton rbPollo, rbTernera, rbVegana;
    private float precioTotal;
    private TextView tv;
    private ImageView imgvFoto;
    private Spinner spExtras;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        precioTotal = 0;

        chkQueso = (CheckBox) findViewById(R.id.chkQueso);
        chkPepino = (CheckBox) findViewById(R.id.chkPepino);
        chkBacon = (CheckBox) findViewById(R.id.chkBacon);
        tv = (TextView) findViewById(R.id.tvPrecioTotal);
        rgTipoBurger = (RadioGroup) findViewById(R.id.rgTipoBurger);
        rbPollo = (RadioButton) findViewById(R.id.rbPollo);
        rbTernera = (RadioButton) findViewById(R.id.rbTernera);
        rbVegana = (RadioButton) findViewById(R.id.rbVegana);
        imgvFoto = (ImageView) findViewById(R.id.imgvFoto);
        //spExtras = (Spinner) findViewById(R.id.spExtras);

        rbTernera.setOnCheckedChangeListener(this);
        rbPollo.setOnCheckedChangeListener(this);
        rbVegana.setOnCheckedChangeListener(this);
        chkBacon.setOnCheckedChangeListener(this);
        chkQueso.setOnCheckedChangeListener(this);
        chkPepino.setOnCheckedChangeListener(this);
    }

    public void seleccionar(View v)
    {

    }

    @Override
    public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {

        switch (buttonView.getId()) {

            case R.id.rbTernera:
                if(isChecked)
                {
                    precioTotal += 2.25;
                    imgvFoto.setImageResource(hamburguesa_ternera);
                }

                else
                {
                    precioTotal -= 2.25;
                }

            case R.id.rbPollo:
                if(isChecked)
                {
                    precioTotal += 2;
                    imgvFoto.setImageResource(hamburguesa_pollo);
                }

                else
                {
                    precioTotal -= 2;
                }

            case R.id.rbVegana:
                if(isChecked)
                {
                    precioTotal += 3;
                    imgvFoto.setImageResource(hamburguesa_vegana);
                }

                else
                {
                    precioTotal -= 3;
                }

            case R.id.chkPepino:
                if (((CheckBox) buttonView).isChecked()) {
                    precioTotal += 0.25;
                } else {
                    precioTotal -= 0.25;
                }
                break;
            case R.id.chkBacon:
                if (((CheckBox) buttonView).isChecked()) {
                    precioTotal += 0.35;
                } else {
                    precioTotal -= 0.35;
                }
                break;
            case R.id.chkQueso:
                if (((CheckBox) buttonView).isChecked()) {
                    precioTotal += 0.15;
                } else {
                    precioTotal -= 0.15;
                }
                break;

        }

        tv.setText("Total: " + precioTotal + "€");

    }
    /*
    spExtras.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener()
    {
        @Override
                public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l)
        {
            switch(i)
            {
                case 0:

            }
        }
    } */
}
