package com.example.radiobuttons;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private RadioButton rbLeon, rbAguila, rbTigre;
    private Button btnSeleccionar;
    TextView tv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        rbLeon = (RadioButton)findViewById(R.id.rbLeon);
        rbAguila = (RadioButton)findViewById(R.id.rbAguila);
        rbTigre = (RadioButton)findViewById(R.id.rbTigre);
        btnSeleccionar = (Button)findViewById(R.id.btnSeleccionar);
        tv = (TextView)findViewById(R.id.tv);

        btnSeleccionar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(rbTigre.isChecked())
                {
                    tv.setText(R.string.tigre);
                }

                if(rbAguila.isChecked())
                {
                    tv.setText(R.string.aguila);
                }

                if(rbLeon.isChecked())
                {
                    tv.setText(R.string.leon);
                }
            }
        });

    }
}