using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<object> Get(Guid eventId)
    {
        using (var httpClient = new HttpClient())
        {
            httpClient.BaseAddress = new Uri(URL);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await httpClient.GetAsync("api/Questions/GetList/{eventId}");
            if (response.StatusCode != HttpStatusCode.OK)
                return null;
            var resourceJson = await response.Content.ReadAsStringAsync();
            return JsonUtility.FromJson<Resource>(resourceJson);
        }
    }
