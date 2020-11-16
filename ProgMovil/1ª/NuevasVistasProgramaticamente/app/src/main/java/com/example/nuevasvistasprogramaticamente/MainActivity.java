package com.example.nuevasvistasprogramaticamente;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        LinearLayout layoutPrincipal = (LinearLayout) findViewById(R.id.layoutPrincipal);
        layoutPrincipal.setOrientation(LinearLayout.VERTICAL);
        TextView tv = new TextView(this);
        tv.setText("Texto generado programáticamente");
        tv.setTextSize(15);
        tv.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
        layoutPrincipal.addView(tv);

        LinearLayout ly = new LinearLayout(getApplicationContext());
        ly.setOrientation(LinearLayout.VERTICAL);
        ly.setGravity(Gravity.CENTER);

        Button btn1 = new Button(this);
        btn1.setText("Botón 1");
        Button btn2 = new Button (this);
        btn2.setText("Botón 2");

        /*LinearLayout.LayoutParams ly2 = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.MATCH_PARENT, 1.0f);

        btn1.setLayoutParams(ly2);
        btn2.setLayoutParams(ly2); */

        ly.addView(btn1);
        ly.addView(btn2);
        layoutPrincipal.addView(ly);
    }
}