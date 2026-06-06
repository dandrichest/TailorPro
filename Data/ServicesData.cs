namespace TailorPro.Data;

public static class ServicesData
{
    public static List<ServiceItem> All { get; } = new()
    {
        new(1, "Bespoke Suit", "A fully custom-fitted suit sewn from your chosen fabric to exact measurements.", "Formal", "7–10 days",
            850, "#dce8cc",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><rect x="18" y="10" width="28" height="44" rx="4" fill="#2D5016"/><path d="M26 10 L32 22 L38 10" stroke="#A8D45A" stroke-width="2" fill="none" stroke-linecap="round"/><rect x="28" y="26" width="8" height="12" rx="2" fill="#A8D45A"/></svg>""",
            "images/bespoke-suit.jpg"),

        new(3, "Dress Shirt", "Tailored slim or classic fit shirt in premium cotton or linen of your choice.", "Casual", "3–5 days",
            280, "#e8f0dc",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><path d="M20 12 L12 24 L20 26 L20 54 L44 54 L44 26 L52 24 L44 12 L36 18 L28 18 Z" fill="#4a8a1e"/><path d="M28 18 L32 28 L36 18" stroke="#fff" stroke-width="1.5" fill="none" stroke-linecap="round"/></svg>""",
            "images/ladies-skirt-suit.jpg"),

        new(4, "Kente Gown", "Traditional Ghanaian kente-accented gown for ceremonies and special occasions.", "Traditional", "5–8 days",
            620, "#f5efe0",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><path d="M32 8 L20 20 L18 56 L46 56 L44 20 Z" fill="#8B2635"/><path d="M20 30 L44 30" stroke="#EDE8DC" stroke-width="3"/><path d="M20 38 L44 38" stroke="#EDE8DC" stroke-width="3"/><path d="M26 20 L38 20" stroke="#EDE8DC" stroke-width="3"/><circle cx="32" cy="12" r="5" fill="#8B2635" stroke="#EDE8DC" stroke-width="2"/></svg>""",
            "images/kente-gown.jpg"),

        new(5, "Trouser Hemming", "Professional hemming and adjustment to achieve the perfect trouser length and fit.", "Alteration", "Same day",
            60, "#edf3e6",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><path d="M22 10 L22 54 L32 44 L42 54 L42 10 Z" fill="#2D5016" opacity="0.85"/><path d="M22 10 L42 10" stroke="#A8D45A" stroke-width="2.5" stroke-linecap="round"/></svg>""",
            "images/trouser-hemming.jpg"),

        new(6, "Ladies Skirt Suit", "Elegant two-piece skirt suit tailored for office and formal events.", "Formal", "6–9 days",
            720, "#f0e8f5",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><rect x="20" y="10" width="24" height="20" rx="3" fill="#6B3A8B"/><path d="M18 32 L20 54 L44 54 L46 32 Z" fill="#8B52A8"/><rect x="28" y="14" width="8" height="4" rx="1" fill="#D4A8E8"/></svg>""",
            "images/ladies-skirt-suit.jpg"),

        new(7, "Senator Wear", "Premium native senator outfit with matching fabric cap, tailored to your measurements.", "Native", "5–7 days",
            480, "#fdf0e0",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><path d="M20 18 L16 54 L48 54 L44 18 Q32 10 20 18 Z" fill="#C67C2A"/><path d="M24 24 Q32 20 40 24" stroke="#fff" stroke-width="1.5" fill="none" stroke-linecap="round"/><ellipse cx="32" cy="14" rx="10" ry="6" fill="#C67C2A" stroke="#fff" stroke-width="1.5"/></svg>""",
            "images/senator-wear.jpg"),

        new(8, "Wedding Dress", "Bespoke bridal gown with premium lace, beading, and flowing silhouette of your design.", "Bridal", "14–21 days",
            1800, "#f9f5f0",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><path d="M32 8 C26 8 22 14 22 18 L16 54 L48 54 L42 18 C42 14 38 8 32 8 Z" fill="#EDE8DC" stroke="#ddd" stroke-width="1"/><circle cx="32" cy="10" r="4" fill="#EDE8DC" stroke="#ccc" stroke-width="1.5"/><path d="M20 38 Q32 34 44 38" stroke="#ccc" stroke-width="1.5" fill="none"/><path d="M17 46 Q32 40 47 46" stroke="#ccc" stroke-width="1.5" fill="none"/></svg>""",
            "images/wedding-dress.jpg"),

        new(9, "Zip & Button Repair", "Fast professional repairs — replacing zippers, buttons, and broken seams on any garment.", "Alteration", "Same day",
            35, "#e6f0f8",
            """<svg width="64" height="64" viewBox="0 0 64 64" fill="none"><circle cx="32" cy="32" r="16" fill="#185FA5" opacity="0.15"/><circle cx="32" cy="32" r="10" fill="none" stroke="#185FA5" stroke-width="2"/><circle cx="28" cy="28" r="2" fill="#185FA5"/><circle cx="36" cy="28" r="2" fill="#185FA5"/><circle cx="28" cy="36" r="2" fill="#185FA5"/><circle cx="36" cy="36" r="2" fill="#185FA5"/></svg>""",
            "images/zip-button-repair.jpg"),
    };
}
