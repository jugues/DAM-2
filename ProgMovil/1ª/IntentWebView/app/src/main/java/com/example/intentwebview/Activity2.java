package com.example.intentwebview;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.webkit.WebView;

public class Activity2 extends AppCompatActivity {

    private WebView w;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_2);

        w = (WebView) findViewById(R.id.webview);
        Bundle b = getIntent().getExtras();
        String url = b.getString("url");
        w.loadUrl("https://" + url);

    }
}