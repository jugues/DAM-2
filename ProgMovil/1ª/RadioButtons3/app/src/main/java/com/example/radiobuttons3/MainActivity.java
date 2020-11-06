package com.example.radiobuttons3;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements RadioGroup.OnCheckedChangeListener {

    private RadioButton rbLeon, rbAguila, rbTigre;
    private Button btnSeleccionar;
    private ImageView imgv;
    private RadioGroup rbGrupo;
    private TextView tv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        rbLeon = (RadioButton) findViewById(R.id.rbLeon);
        rbAguila = (RadioButton) findViewById(R.id.rbAguila);
        rbTigre = (RadioButton) findViewById(R.id.rbTigre);
        imgv = (ImageView) findViewById(R.id.imgview);
        rbGrupo = (RadioGroup) findViewById(R.id.rbGrupo);
        tv = (TextView) findViewById(R.id.tv);

        rbGrupo.setOnCheckedChangeListener(this);

        /* rbAguila.setOnClickListener(this);
        rbTigre.setOnClickListener(this);
        rbLeon.setOnClickListener(this); */

    }

    /* @Override
    public void onClick(View v) {
        switch(v.getId())
        {
            case R.id.rbTigre:
                imgv.setImageResource(R.drawable.tiger);
                break;

            case R.id.rbAguila:
                imgv.setImageResource(R.drawable.eagle);
                break;

            case R.id.rbLeon:
                imgv.setImageResource(R.drawable.lion);
                break;
        }} */


    @Override
    public void onCheckedChanged(RadioGroup group, int checkedId) {

        switch(checkedId)
        {
            case R.id.rbTigre:
                tv.setText(R.string.tigre);
                imgv.setImageResource(R.drawable.tiger);
                break;

            case R.id.rbAguila:
                tv.setText(R.string.aguila);
                imgv.setImageResource(R.drawable.eagle);
                break;

            case R.id.rbLeon:
                tv.setText(R.string.leon);
                imgv.setImageResource(R.drawable.lion);
                break;
        }
    }
}