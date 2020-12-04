package com.example.cronometro;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private Button btnIniciar, btnFinalizar;
    private TextView tvTiempo;
    private Thread hiloCrono;
    private Handler handler = new Handler();
    private boolean cronometroCorriendo = false;
    private int minutos, segundos, centesimas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnIniciar = findViewById(R.id.btnIniciar);
        btnFinalizar = findViewById(R.id.btnFinalizar);
        tvTiempo = findViewById(R.id.tvTiempo);
        btnIniciar.setOnClickListener(this);
        btnFinalizar.setOnClickListener(this);

        hiloCrono = new Thread(new Runnable() {
            @Override
            public void run() {
                while(true)
                {
                    if(cronometroCorriendo)
                    {
                        try {

                                centesimas += 1;
                                if (centesimas > 99) {
                                    segundos++;
                                    centesimas = 0;
                                }

                                if(segundos > 59) {
                                    minutos++;
                                    segundos = 0;
                                }

                                handler.post(new Runnable()
                                {
                                    @Override
                                    public void run() {
                                        String cadMinutos = "";
                                        String cadSegundos = "";
                                        String cadCentesimas = "";

                                        if(centesimas < 10)
                                        {
                                            cadCentesimas = "0" + centesimas;
                                        }

                                        else
                                        {
                                            cadCentesimas = "" + centesimas;
                                        }

                                        if(segundos < 10)
                                        {
                                            cadSegundos = "0" + segundos;
                                        }

                                        else
                                        {
                                            cadSegundos = "" + segundos;
                                        }

                                        if(minutos < 10)
                                        {
                                            cadMinutos = "0" + minutos;
                                        }

                                        else
                                        {
                                            cadMinutos = "" + minutos;
                                        }

                                        tvTiempo.setText(cadMinutos + ":" + cadSegundos + ":" + cadCentesimas);
                                    }
                                });
                                Thread.sleep(10);
                            } catch (InterruptedException e) {
                            e.printStackTrace();
                        }

                     }
                    }

                        }
                    });
        hiloCrono.start();
    }

    @Override
    public void onClick(View v) {

        switch(v.getId())
        {
            case R.id.btnIniciar:
                if(!cronometroCorriendo)
                {
                    cronometroCorriendo = true;
                    btnIniciar.setText("Pausar");
                }

                else
                {
                    cronometroCorriendo = false;
                    btnIniciar.setText("Reanudar");
                }
                break;

            case R.id.btnFinalizar:
                cronometroCorriendo = false;
                tvTiempo.setText("00:00:00");
                btnIniciar.setText("Iniciar");
                centesimas = 0;
                segundos = 0;
                minutos = 0;
                Toast.makeText(getApplicationContext(), "Finalizado", Toast.LENGTH_LONG);
                break;
        }

    }
}