import pandas as pd

df = pd.read_csv("/Users/pavandeekshith/B-Tech/Btech_3rd_Year/6th_Sem/STT/lab9/lcom_output/TypeMetrics.csv")

LCOM1_THRESHOLD = 10
LCOM5_THRESHOLD = 0.85
YALCOM_THRESHOLD = 0.6

# Ensure relevant columns exist
required_columns = ['LCOM1', 'LCOM5', 'YALCOM']
for col in required_columns:
    if col not in df.columns:
        raise ValueError(f"Missing column in CSV: {col}")

# Filter rows that exceed any one of the thresholds
high_lcom_df = df[
    (df['LCOM1'] > LCOM1_THRESHOLD) &
    (df['LCOM5'] > LCOM5_THRESHOLD) &
    (df['YALCOM'] > YALCOM_THRESHOLD)
]

print(f"Total classes with high LCOM1, LCOM5, or YALCOM values: {len(high_lcom_df)}")
print(high_lcom_df[['Project Name', 'Package Name', 'Type Name', 'LCOM1', 'LCOM5', 'YALCOM']].head(15))
high_lcom_df.to_csv("high_lcom_classes.csv", index=False)
print("Filtered data saved to 'high_lcom_classes.csv'")
